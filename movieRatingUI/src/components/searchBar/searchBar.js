import React, { useEffect, useState } from "react";
import axios from "axios";
import "./searchBar-styles.css";

function SearchBar() {
  const [data, setData] = useState([]);
  const [searchTerm, setSearchTerm] = useState("");

  useEffect(() => {
    getDataFrom();
  }, []);

  const getDataFrom = () => {
    axios.post(`https://localhost:44317/api/Movie/search`).then((res) => {
      setData(res.data);
    });
  };

  return (
    <div className="searchbar">
      <input
        type="text"
        placeholder="Search..."
        onChange={(event) => {
          setSearchTerm(event.target.value);
        }}
      />
      <div className="Container">
        {data
          .filter((val) => {
            if (searchTerm == "") {
              return null;
            } else if (
              val.title.toLowerCase().includes(searchTerm.toLowerCase()) ||
              val.description.toLowerCase().includes(searchTerm.toLowerCase())
            ) {
              return val;
            }
          })
          .map((dataEntry, id) => {
            return (
              <div className="subContainer" key={id}>
                <div className="searchImg">
                  <img
                    src={
                      require(`../../Images/${dataEntry.coverImage}`).default
                    }
                    alt={dataEntry.coverImage}
                  />
                </div>
                <div className="searchText">
                  <h3 className="card-title">{dataEntry.title}</h3>
                  <p className="card-text text-secondary">
                    {dataEntry.description}
                  </p>
                  <p className="card-text text-secondary">
                    {dataEntry.releaseDate}
                  </p>
                  <p className="card-text text-secondary">
                    {dataEntry.AvgScore}
                  </p>
                </div>
              </div>
            );
          })}
      </div>
    </div>
  );
}

export default SearchBar;
