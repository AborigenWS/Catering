import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import AuthContainer from './components/Auth/AuthContainer';
import RegContainer from './components/Registration/RegContainer';

export default () => (
    <Layout>
        <Route exact path='/' component={AuthContainer} />
        <Route path='/auth' component={AuthContainer} />
        <Route path='/registration' component={RegContainer} />
    </Layout>
);
