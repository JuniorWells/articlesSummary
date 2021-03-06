import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router';
import Label from '../../components/Label';
import Empty from '../../components/Empty';
import './styles.css';
import { Link } from 'react-router-dom';

const Blog = () => {
  const { id } = useParams();
  const [ blog, setBlog ] = useState(null);

  useEffect(() => {
      search(id);
  }, []);

  const search = async ( id ) => {
      const result = await fetch(`https://localhost:7260/api/Blog/${id}`)
          .then(response => response.json())
          .then(data => setBlog(data))
          .catch(error => console.log(error))
          return result;
  }

  return (
    <>
      <Link className='blog__goBack' to='/'>
        <span> &#8592;</span> <span>Go Back</span>
      </Link>
      {blog ? (
        <div className='blog__wrap'>
          <header>
            <p className='blog__date'>Published {blog.createdAt}</p>
            <h1>{blog.title}</h1>
            <div className='blog__subCategory'>
              <Label label={blog.category} />
            </div>
          </header>
          <img src={blog.cover} alt='cover' />
          <p className='blog__desc'>{blog.description}</p>
        </div>
      ) : (
        <Empty />
      )}
    </>
  );
};

export default Blog;