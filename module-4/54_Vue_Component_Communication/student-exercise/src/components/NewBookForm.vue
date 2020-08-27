<template>
    <form class="new-book-form" v-on:submit.prevent="saveNewBook">
        <input class="title-input" placeholder="Title" type="text" v-model="book.title" />
        <input class="author-input" placeholder="Author" type="text" v-model="book.author" />
        <input class="isbn-input" placeholder="ISBN" type="text" v-model="book.isbn" />
        <button>Save</button>
    </form>
</template>

<script>
export default {
    name:"new-book-form",
    data() {
        return {
            book: {
                title: '',
                author: '',
                read: false,
                isbn: ''
            }
        }
    },
    methods: {
        saveNewBook() {
            this.$store.commit('SAVE_BOOK', this.book);
            this.book = {
                title: '',
                author: '',
                read: false,
                isbn: ''
            };
        }
    }
}
</script>