import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import CheckInContainer from './components/Check-in/CheckInContainer';

export default () => (
    <Layout>
        <Route exact path='/' component={CheckInContainer} />
    </Layout>
);
