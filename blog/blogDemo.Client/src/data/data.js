const fetchData = async () => {
  const response = await fetch("https://localhost:7260/api/Blog");
  const temp =  await response.json();
  return temp;
}

const arr = [];
fetchData()
  .then(response => {
    arr.push(...response);
  });

console.log(arr);



const blogList = arr;
export default blogList;