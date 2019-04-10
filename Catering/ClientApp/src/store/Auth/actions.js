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

export const sendAccount = (state) => {
    fetch('/api/Account/Test', {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            email: state.email,
            password: state.password
        })
    })
        //.then((response) => {
        //    if (response.status !== 200) console.log('fetch dont work');
        //    response.json().then((data) => console.log('ok  ' + data));
        //})
        //.catch((error) => {
        //    window.alert('Failed ' + error, error)
        //});
};