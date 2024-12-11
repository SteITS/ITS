const tipino = {
    name: 'Green Mueller',
    email: 'Rigoberto_Muller47@yahoo.com',
    address: '575 Aiden Forks',
    bio: 'Tenetur voluptatem odit labore et voluptatem vel qui placeat sit.',
    bankInformation: {
        amount: '802.04',
        business: 'Bernhard, Kuhn and Stehr',
        name: 'Investment Account 8624',
        type: 'payment',
        account: '34889694',
    },
};

function cloneStrings(obj) {
    if (typeof obj !== 'object' || obj === null) {
        return null;
    }

    const result = Array.isArray(obj) ? [] : {};

    for (const key in obj) {
        if (Object.prototype.hasOwnProperty.call(obj, key)) {
            const value = obj[key];

            
            if (typeof value === 'string') {
                result[key] = value;
            } 
            else if (typeof value === 'object' && value !== null) {
                result[key] = cloneStrings(value);
            }
        }
    }

    return result;
}

console.log(cloneStrings(tipino));
