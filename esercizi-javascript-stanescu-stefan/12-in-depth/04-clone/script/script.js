const original = {
    name: 'Green Mueller',
    email: 'Rigoberto_Muller47@yahoo.com',
    address: '575 Aiden Forks',
    bio: 'Tenetur voluptatem odit labore et voluptatem vel qui placeat sit.',
    active: false,
    salary: 37993,
    birth: new Date('1965-04-18T11:38:00Z'),
    bankInformation: {
        amount: '802.04',
        date: new Date('2012-02-02T00:00:00Z'),
        business: 'Bernhard, Kuhn and Stehr',
        name: 'Investment Account 8624',
        type: 'payment',
        account: '34889694'
    }
};

function clone(obj) {
    let clonedObj = {};
    for (let key in obj) {
        if (obj[key] !== null && typeof obj[key] === 'object') {
            clonedObj[key] = clone(obj[key]);
        } else {
            clonedObj[key] = obj[key];
        }
    }
    return clonedObj;
}

const cloned = clone(original);
cloned.name = 'Blue Mueller';

console.log('Original:', original);
console.log('Cloned:', cloned);
