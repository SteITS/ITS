function calculateSupply(cage,cof) {
    fage=78;
    console.log("You will need",(fage-cage)*(365*cof),"cups of coffee to last you until the age of",fage)
}


calculateSupply(Math.floor(Math.random() * 50),Math.floor(Math.random() * 11));
calculateSupply(Math.floor(Math.random() * 50),Math.floor(Math.random() * 11));
calculateSupply(Math.floor(Math.random() * 50),Math.floor(Math.random() * 11));

