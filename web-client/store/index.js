import Axios from "axios"
const initState=()=>({
    message:"Init"
})

export const state=initState

export const mutations={
    setMessage(state,message){
        state.message=message
    },
    reset(state){
        Object.assign(state,initState());
    }
}

export const actions={
     nuxtServerInit({commit}){
        debugger;
        //const message=(await Axios.get('http://localhost:5000/api/home')).data;
        message="test"
        console.log(message);
        commit("setMessage",message);
        //await dispatch('tricks/fetchTricks');
    }
}