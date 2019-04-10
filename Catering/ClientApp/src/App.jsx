import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home/Home';
import AuthContainer from './components/Auth/AuthContainer';
import RegContainer from './components/Registration/RegContainer';

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/auth' component={AuthContainer} />
        <Route path='/registration' component={RegContainer} />
    </Layout>
);
