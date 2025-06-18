from pymongo import MongoClient

# Connect to MongoDB
client = MongoClient("mongodb://localhost:27017/")
db = client["restaurant_db"]

# Fetch the customers collection
customers = db["customers"]

# Transform the data
for customer in customers.find():
    delivery_address = {
        "street": customer.get("delivery_address_street"),
        "city": customer.get("delivery_address_city"),
        "zip": customer.get("delivery_address_zip"),
    }

    customers.update_one(
        {"_id": customer["_id"]},
        {
            "$set": {"delivery_address": delivery_address},
            "$unset": {
                "delivery_address_street": "",
                "delivery_address_city": "",
                "delivery_address_zip": ""
            }
        }
    )
print("Customer transformation complete! Check the 'customers' collection.")
