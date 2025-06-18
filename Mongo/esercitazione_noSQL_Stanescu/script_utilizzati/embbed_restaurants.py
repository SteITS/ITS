from pymongo import MongoClient

# Connect to MongoDB
client = MongoClient("mongodb://localhost:27017/")
db = client["restaurant_db"]

# Fetch the restaurants collection
customers = db["restaurants"]

# Transform the data
for customer in customers.find():
    delivery_address = {
        "street": customer.get("address_street"),
        "city": customer.get("address_city"),
        "zip": customer.get("address_zip"),
    }

    customers.update_one(
        {"_id": customer["_id"]},
        {
            "$set": {"delivery_address": delivery_address},
            "$unset": {
                "address_street": "",
                "address_city": "",
                "address_zip": ""
            }
        }
    )
print("Customer transformation complete! Check the 'restaurants' collection.")
