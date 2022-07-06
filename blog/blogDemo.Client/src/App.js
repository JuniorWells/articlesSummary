import React from 'react';
import { Route, Routes } from 'react-router-dom';
import Home from './pages/Home/';
import Blog from './pages/Blog';
import './App.css';

function App() {
  return (
    <div className='container'>
      <Routes>
        <Route path='/' element={<Home />}/>
        <Route path='/Blog/:id' element={<Blog />}/>

      </Routes>
    </div>
  );
}

export default App;
