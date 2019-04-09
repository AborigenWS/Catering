import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import AuthContainer from './components/Auth/AuthContainer';

export default () => (
    <Layout>
        <Route exact path='/' component={AuthContainer} />
    </Layout>
);
