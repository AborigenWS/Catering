export const REGISTR_CHANGE_EMAIL_TEXT = 'REGISTR IN_CHANGE_EMAIL_TEXT';
export const REGISTR_CHANGE_PASSWORD_TEXT = 'REGISTR_CHANGE_PASSWORD_TEXT';
export const REGISTR_CHANGE_REPEATPASSWORD_TEXT = 'REGISTR_CHANGE_REPEATPASSWORD_TEXT';


export const setEmailText = (email) => ({
    type: REGISTR_CHANGE_EMAIL_TEXT,
    payload: email
});

export const setPasswordText = (password) => ({
    type: REGISTR_CHANGE_PASSWORD_TEXT,
    payload: password 
});

export const setRepeatPasswordText = (repeatPassword) => ({
    type: REGISTR_CHANGE_REPEATPASSWORD_TEXT,
    payload: repeatPassword
});