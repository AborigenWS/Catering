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
    return function kostul() {
        const request = fetch('/api/account/test', {
            method: 'post',
            body: JSON.stringify({
                email: state.email,
                password: state.password
            }),
            headers: { 'Content-Type': 'application/json' }
        });
        return request.then((response) => {
            if (response.ok) {
                window.alert('Это response ok');
                response.json();
            }
        })
            .catch((error) => {
                window.alert(error);
            });
    }
}