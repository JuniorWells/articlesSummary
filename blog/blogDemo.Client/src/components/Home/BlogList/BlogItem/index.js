import React from 'react';
import { Link } from 'react-router-dom';
import Label from '../../../Label';
import './styles.css';

const BlogItem = ({
  blog: {
    description,
    title,
    createdAt,
    authorName,
    cover,
    category,
    id,
  },
}) => {
  return (
    <div className='blogItem__wrap'>
      <img className='blogItem__cover' src={cover} alt='cover' />
      <Label label={category} />
      <h3>{title}</h3>
      <p className='blogItem__desc'>{description}</p>
      <footer>
        <div className='blogItem__author'>
          <div>
            <h6>{authorName}</h6>
            <p>{createdAt}</p>
          </div>
        </div>
        <Link className='blogItem__link' to={`/blog/${id}`}>
          ➝
        </Link>
      </footer>
    </div>
  );
};

export default BlogItem;