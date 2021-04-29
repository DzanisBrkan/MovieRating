import React, { useState } from "react";
import {
  BrowserRouter as Router,
  Route,
  Switch,
  Redirect,
} from "react-router-dom";
import Movies from "../components/movies/movies";
import TvShows from "../components/tvshows/tv-shows";
import { Switch as ToogleSwitch } from "antd";
import SearchBar from "../components/searchBar/searchBar";

const HomePage = () => {
  const [toggle, setToggle] = useState(false);

  const toggler = () => {
    toggle ? setToggle(false) : setToggle(true);
  };

  return (
    <>
      <SearchBar />
      <ToogleSwitch onClick={toggler} />
      <Router>
        {toggle ? (
          <Redirect push to="/tvshows" />
        ) : (
          <Redirect push to="/movies" />
        )}

        <Switch>
          <Route path="/movies" exact component={Movies} />
          <Route path="/tvshows" component={TvShows} />
        </Switch>
      </Router>
    </>
  );
};

export default HomePage;
