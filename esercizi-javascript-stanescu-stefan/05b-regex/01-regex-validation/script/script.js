/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Checks if the first string contains the second string.
 *
 * @param {string} str1 - The string to be searched.
 * @param {string} str2 - The string to search for.
 * @returns {boolean} True if the first string contains the second string, otherwise false.
 */
document.getElementById('validationForm').addEventListener('submit', function(event) {
    event.preventDefault();

    // Regular expressions
    const emailPattern = /^[^\s@]+@[^\s@]+\.[a-zA-Z]{2,4}$/;
    const phonePattern = /^\+?\d{1,3}?[-.\s]?\(?\d{1,4}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,9}$/;
    const passwordPattern = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
    const urlPattern = /^(https?:\/\/)?([\da-z.-]+)\.([a-z.]{2,6})([/\w .-]*)*\/?(\?[^\s#]*)?(#[\w-]*)?$/;

    // Input values
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;
    const password = document.getElementById('password').value;
    const url = document.getElementById('url').value;

    // Feedback elements
    const emailFeedback = document.getElementById('emailFeedback');
    const phoneFeedback = document.getElementById('phoneFeedback');
    const passwordFeedback = document.getElementById('passwordFeedback');
    const urlFeedback = document.getElementById('urlFeedback');

    // Email validation
    if (emailPattern.test(email)) {
        emailFeedback.textContent = "Valid email";
        emailFeedback.className = "valid";
    } else {
        emailFeedback.textContent = "Invalid email";
        emailFeedback.className = "invalid";
    }

    // Phone validation
    if (phonePattern.test(phone)) {
        phoneFeedback.textContent = "Valid phone number";
        phoneFeedback.className = "valid";
    } else {
        phoneFeedback.textContent = "Invalid phone number";
        phoneFeedback.className = "invalid";
    }

    // Password validation
    if (passwordPattern.test(password)) {
        passwordFeedback.textContent = "Valid password";
        passwordFeedback.className = "valid";
    } else {
        passwordFeedback.textContent = "Invalid password";
        passwordFeedback.className = "invalid";
    }

    // URL validation
    if (urlPattern.test(url)) {
        urlFeedback.textContent = "Valid URL";
        urlFeedback.className = "valid";
    } else {
        urlFeedback.textContent = "Invalid URL";
        urlFeedback.className = "invalid";
    }
});