const fetchData = async () => {
  const response = await fetch("https://localhost:7260/api/Blog");
  const temp =  await response.json();
  return temp;
}


const data = fetchData().then(post => post);

console.log(data);



const blogList = data;
export default blogList;