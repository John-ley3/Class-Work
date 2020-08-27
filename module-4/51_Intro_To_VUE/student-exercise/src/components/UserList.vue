<template>
  <table id="tblUsers">
    <thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
    </tr>
    </thead>
    <tbody>
      <tr>
        <td><input type="text" v-model="filter.firstName" id="firstNameFilter"/></td>
        <td><input type="text" v-model="filter.lastName" id="lastNameFilter"/></td>
        <td><input type="text" v-model="filter.username" id="usernameFilter"/></td>
        <td><input type="text" v-model="filter.emailAddress" id="emailFilter"/></td>
        <td>
          <select v-model="filter.status" id="statusFilter">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <tr class="user" v-for="(userObject, status) in filteredList" v-bind:key="status" :class="{disabled: userObject.status === 'Disabled'}">
        <td>{{userObject.firstName}}</td>
        <td>{{userObject.lastName}}</td>
        <td>{{userObject.username}}</td>
        <td>{{userObject.emailAddress}}</td>
        <td>{{userObject.status}}</td>
      </tr>
      <!-- user listing goes here -->
    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
  data() {
    return {
      filter: {firstName: '', lastName: '', username: '', emailAddress: '', status: ''},
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Disabled' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }
      ]
    }
  },
  computed: {
    filteredList() {
      let filteredList = this.users;

      if(this.filter.firstName != '')
      {
        filteredList = filteredList.filter((user => user.firstName.toLowerCase().includes(this.filter.firstName.toLowerCase())));
      }
      if(this.filter.lastName != '')
      {
        filteredList = filteredList.filter((user => user.lastName.toLowerCase().includes(this.filter.lastName.toLowerCase())));
      }
      if(this.filter.username != '')
      {
        filteredList = filteredList.filter((user => user.username.toLowerCase().includes(this.filter.username.toLowerCase())));
      }
      if(this.filter.emailAddress != '')
      {
        filteredList = filteredList.filter((user => user.emailAddress.toLowerCase().includes(this.filter.emailAddress.toLowerCase())));
      }
      if(this.filter.status != '')
      {
        filteredList = filteredList.filter(user => user.status === this.filter.status);
      }
      return filteredList;     
    }
  }
}
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif
}
th {
  text-transform: uppercase
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input, select {
  font-size: 16px;
}
</style>
