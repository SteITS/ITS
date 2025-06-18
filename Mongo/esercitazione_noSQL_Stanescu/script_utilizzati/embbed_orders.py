from pymongo import MongoClient

# Connect to MongoDB
client = MongoClient("mongodb://localhost:27017/")
db = client["restaurant_db"]

# Fetch all collections
orders = db["orders"].find()
dishes = {d["_id"]: d for d in db["dishes"].find()}
restaurants = {r["_id"]: r for r in db["restaurants"].find()}
customers = {c["_id"]: c for c in db["customers"].find()}

# Create the enhanced_orders collection
enhanced_orders = db["enhanced_orders"]
enhanced_orders.drop()  # Remove if exists

# Transform and insert data
for order in orders:
    # Embed customer details
    customer = customers.get(order["customer_id"], {})
    customer_details = {
        "name": customer.get("name"),
        "email": customer.get("email"),
        "delivery_address": {
            "street": customer.get("delivery_address_street"),
            "city": customer.get("delivery_address_city"),
            "zip": customer.get("delivery_address_zip"),
        },
    }

    # Embed restaurant details
    restaurant = restaurants.get(order["restaurant_id"], {})
    restaurant_details = {
        "name": restaurant.get("name"),
        "address": {
            "street": restaurant.get("address_street"),
            "city": restaurant.get("address_city"),
            "zip": restaurant.get("address_zip"),
        },
        "cuisine": restaurant.get("cuisine"),
    }

    # Embed dish details
    order_dishes = []
    for dish_id in [order.get("dish_id")]:  # Assuming 1 dish per order line
        dish = dishes.get(dish_id, {})
        order_dishes.append({
            "name": dish.get("name"),
            "description": dish.get("description"),
            "price": dish.get("price"),
            "quantity": order["quantity"]
        })

    # Build the enhanced order document
    enhanced_order = {
        "order_id": order["order_id"],
        "customer": customer_details,
        "restaurant": restaurant_details,
        "dishes": order_dishes,
        "order_date": order["order_date"],
        "status": order["status"],
        "total_cost": order["total_cost"],
    }

    # Insert into enhanced_orders collection
    enhanced_orders.insert_one(enhanced_order)

print("Transformation complete! Check the 'enhanced_orders' collection.")