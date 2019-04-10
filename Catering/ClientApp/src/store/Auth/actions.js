export const AUTH_CHANGE_EMAIL_TEXT = 'AUTH IN_CHANGE_EMAIL_TEXT';
export const AUTH_CHANGE_PASSWORD_TEXT = 'AUTH_CHANGE_PASSWORD_TEXT';

export const setEmailText = (email) => ({
    type: AUTH_CHANGE_EMAIL_TEXT,
    payload: email
});

export const setPasswordText = (password) => ({
    type: AUTH_CHANGE_PASSWORD_TEXT,
    payload: password 
});

export const sendAccount = () => {
    console.log('start to send message');
    fetch('/api/Account/Test', {
        method: 'post',
        body: JSON.stringify({
            email: 'emailfwefw',
        })
    })
        .then((response) => {
            if (response.status !== 200) console.log('fetch dont work');
            response.json().then((data) => console.log('ok  ' + data));
        })
        .catch((error) => {
            window.alert('Failed', error)
        });
};