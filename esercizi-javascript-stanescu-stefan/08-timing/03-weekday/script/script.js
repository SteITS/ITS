/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * log week day either in italian or in english, based on input
 */


function getWeekDay(date, language = 'en'){

    const dateEn = ['MO', 'TU', 'WE', 'TH', 'FR', 'SA', 'SU'];

    const dateIt = ['LU', 'MA', 'ME', 'GI', 'VE', 'SA', 'DO'];

    const dayIndex =date.getDay();

    if(language === 'en')
        return dateEn[dayIndex];
    else if(language === 'it')
        return dateIt[dayIndex];
    else
        return 'Invalid language';
}

const databella = new Date('2000-12-12')

console.log(getWeekDay(databella,'it'));
console.log(getWeekDay(databella,'en'));