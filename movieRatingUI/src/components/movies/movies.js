import axios from "axios";
import React, { useEffect, useState } from "react";
import "./movies-styles.css";

const Movies = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    getDataFrom();
  }, []);

  //get data from server and push in serverResponse
  const getDataFrom = () => {
    axios.get(`https://localhost:44317/api/Movie/getmovies`).then((res) => {
      setData(res.data);
      console.log(res);
    });
  };
  return (
    <>
      <div className="navigation">
        <h3>Top 10 rated Movies</h3>
      </div>

      <div className="card-container">
        {data.map((dataEntry, id) => {
          return (
            <div className="sub-card-container" key={id}>
              <div>
                <img
                  src={require(`../../Images/${dataEntry.coverImage}`).default}
                  alt={dataEntry.coverImage}
                />
              </div>
              <div className="card-body text-dark text-center">
                <h3 className="card-title">{dataEntry.title}</h3>
                <p className="card-text text-secondary">
                  {dataEntry.description}
                </p>
                <p className="card-text text-secondary">
                  {dataEntry.releaseDate}
                </p>
                <p className="card-text text-secondary">{dataEntry.AvgScore}</p>
                <a href="#" className="btn btn-outline-success">
                  Cast details
                </a>
              </div>
            </div>
          );
        })}
      </div>
    </>
  );
};

export default Movies;
