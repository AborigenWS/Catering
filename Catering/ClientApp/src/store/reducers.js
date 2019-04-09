import { combineReducers } from 'redux';
import { authReducer } from './Auth/reducers';
import { registrationReducer } from './Registration/reducers';
import { connectRouter } from 'connected-react-router'
import { createBrowserHistory } from 'history';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const history = createBrowserHistory({ basename: baseUrl });

export default combineReducers({
    auth: authReducer,
    reg: registrationReducer,
    router: connectRouter(history)
});