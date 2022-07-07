import React, { useState } from "react";
import BlogList from "../../components/Home/BlogList";
import Header from "../../components/Home/Header";
import SearchBar from "../../components/Home/SearchBar";
import Empty from "../../components/Empty";
import blogList from "../../data/data";

const Home = () => {
    const [blogs, setBlogs] = useState(blogList);
    const [searchKey, setSearchKey] = useState('');

    const handleSearchBar = (e) => {
        e.preventDefault();
        handleSearchResults();
    }

    const handleSearchResults = () => {
        const allBlogs = blogList;
        const filteredBlogs = allBlogs.filter((blog) =>
          blog.category.toLowerCase().includes(searchKey.toLowerCase().trim())
        );
        setBlogs(filteredBlogs);
    }

    const handleClearSearch = () => {
        setBlogs(blogList);
        setSearchKey('');
    };

    return (
        <div>
            <Header />
            <SearchBar
                value={searchKey}
                clearSearch={handleClearSearch}
                formSubmit={handleSearchBar}
                handleSearchKey={(e) => setSearchKey(e.target.value)} />

            {!blogs.length ? <Empty /> : <BlogList blogs={blogs} />}
        </div>
    );
};

export default Home;