<template>
  <div>
    <div class="loading" v-if="isLoading">
      <img src="../assets/ping_pong_loader.gif" />
    </div>
    <div v-else>
      <h1>{{card.title}}</h1>
      <p>{{card.description}}</p>
      <comments-list v-bind:comments="card.comments" />
    </div>
  <div v-if="!isLoading">
    <router-link v-bind:to="{ name: 'Board',params: {id: $route.params.boardID}}">Back to Board</router-link>
  </div>
  </div>
</template>

<script>
import boardsService from "../services/BoardService";
import CommentsList from "@/components/CommentsList";

export default {
  name: "card-detail",
  components: {
    CommentsList,
  },
  data() {
    return {
      card: {
        title: "",
        description: "",
        status: "",
        comments: [],
      },
      isLoading: true,
    };
  },
  created() {
    boardsService
      .getCard(this.$route.params.boardID, this.$route.params.cardID)
      .then((returnedCard) => {
        this.card = returnedCard;
        this.isLoading = false;
      });
  },
};
</script>
