import { combineReducers } from 'redux';
import { checkInReducer } from './Check-In/reducers';
import { connectRouter } from 'connected-react-router'
import { createBrowserHistory } from 'history';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const history = createBrowserHistory({ basename: baseUrl });

export default combineReducers({
    checkIn: checkInReducer,
    router: connectRouter(history)
});