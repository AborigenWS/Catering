import { REGISTR_CHANGE_EMAIL_TEXT, REGISTR_CHANGE_PASSWORD_TEXT, REGISTR_CHANGE_REPEATPASSWORD_TEXT } from './actions';

const initialState = {
    email: '',
    password: '',
    repeatPassword: ''
};

export const registrationReducer = (state = initialState, action) => {
    switch (action.type) {
        case REGISTR_CHANGE_EMAIL_TEXT:
            return {
                ...state,
                email: action.payload
            };
        case REGISTR_CHANGE_PASSWORD_TEXT:
            return {
                ...state,
                password: action.payload
            };
        case REGISTR_CHANGE_REPEATPASSWORD_TEXT:
            return {
                ...state,
                repeatPassword: action.payload
            }
        default:
            return state;
    }
};