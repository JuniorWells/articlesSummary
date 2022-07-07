import React, { useEffect, useState } from "react";
import BlogList from "../../components/Home/BlogList";
import Header from "../../components/Home/Header";
import SearchBar from "../../components/Home/SearchBar";
import Empty from "../../components/Empty";
import blogList from "../../data/data";
import Loading from "../../components/Loading";
import { usePromiseTracker, trackPromise } from "react-promise-tracker";

const Home = () => {
    const [blogs, setBlogs] = useState([]);
    const [searchKey, setSearchKey] = useState('');
    const { promiseInProgress } = usePromiseTracker();
    const sleep = ms => new Promise(r => setTimeout(r, ms));

    useEffect(() => {
        trackPromise(searchBlogs());
    }, []);

    const searchBlogs = async () => {
        await sleep(2000);
        const result = await fetch('https://localhost:7260/api/Blog')
            .then(response => response.json())
            .then(data => setBlogs(data))
            .catch(error => console.log(error))
            return result;
    }

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

            {promiseInProgress 
                ? <Loading /> 
                : !blogs.length 
                    ? <Empty /> 
                    : <BlogList blogs={blogs} />}
        </div>
    );
};

export default Home;