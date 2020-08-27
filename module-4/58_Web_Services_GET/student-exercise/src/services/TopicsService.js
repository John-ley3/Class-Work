import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {
    getTopics() {
        return http.get('/topics');
    },
    getTopicsInfo(topicID) {
        return http.get(`/topics/${topicID}`);
    }
}