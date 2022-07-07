const fetchData = async () => {
  const response = await fetch("https://localhost:7260/api/Blog");
  const temp =  await response.json();
  return temp;
}

const blogList = [];
fetchData()
  .then(response => blogList.push(...response));

export default blogList;