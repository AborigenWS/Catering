export const CHECKIN_CHANGE_EMAIL_TEXT = 'CHECK IN_CHANGE_EMAIL_TEXT';
export const CHECKIN_CHANGE_PASSWORD_TEXT = 'CHECKIN_CHANGE_PASSWORD_TEXT';

export const setEmailText = (email) => ({
    type: CHECKIN_CHANGE_EMAIL_TEXT,
    payload: email
});

export const setPasswordText = (password) => ({
    type: CHECKIN_CHANGE_PASSWORD_TEXT,
    payload: password 
});