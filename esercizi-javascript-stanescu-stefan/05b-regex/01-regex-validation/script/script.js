/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Misc regex
 */

    // Regular expressions
    const emailPattern = /^[^\s@]+@[^\s@]+\.[a-zA-Z]{2,4}$/;
    const phonePattern = /^\+?\d{1,3}?[-.\s]?\(?\d{1,4}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,9}$/;
    const passwordPattern = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
    const urlPattern = /^(https?:\/\/)?([\da-z.-]+)\.([a-z.]{2,6})([/\w .-]*)*\/?(\?[^\s#]*)?(#[\w-]*)?$/;
;