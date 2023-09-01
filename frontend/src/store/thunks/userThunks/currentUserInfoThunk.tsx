import { createAsyncThunk } from "@reduxjs/toolkit";
import { store } from "../../store";
import axios from "axios";

import { currentUserInfoSlice } from "../../slices/currentUserInfoSlice";

export const currentUserInfoThunk = createAsyncThunk(
  "currentUserInfo/getUserById",
  async (userFromStore: string) => {
    const response = await axios.get(
      `http://localhost:5145/api/v1/users/${userFromStore}`
    );
    store.dispatch(
      currentUserInfoSlice.actions.setCurrentUserInfo(response.data)
    );
    return response.data;
  }
);
