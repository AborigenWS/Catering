import { CHECKIN_CHANGE_EMAIL_TEXT, CHECKIN_CHANGE_PASSWORD_TEXT } from './actions';

const initialState = {
    email: '',
    password: ''
};

export const checkInReducer = (state = initialState, action) => {
    console.log("reducer");
    console.log(state.email + " " + state.password);
    switch (action.type) {
        case CHECKIN_CHANGE_EMAIL_TEXT:
            return {
                ...state,
                email: action.payload
            };
        case CHECKIN_CHANGE_PASSWORD_TEXT:
            return {
                ...state,
                password: action.payload
            };
        default:
            return state;
    }
};