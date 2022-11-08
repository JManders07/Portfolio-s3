<template>
  <div>
      <div>
          <h1>Create beer</h1>
          <hr /><br />
      </div>
      <div>
          
          <div>
              <h4>Beer:</h4>
              <b-form-textarea
                               v-model="form.name"
                               placeholder="Fill in the name here">
              </b-form-textarea>
              <b-form-textarea
                               v-model="form.description"
                               placeholder="Fill in the description here"
                               rows="3"
                               max-rows="5">
              </b-form-textarea>
              <b-form-textarea
                               v-model="form.alcoholpercentage"
                               placeholder="Fill in the alcoholpercentage here"
                               rows="3"
                               max-rows="5">
              </b-form-textarea>
          </div>
          <b-button variant="primary" class="btn" type="submit" @click="onSubmit"><a @click="$router.go(-1)" class="nav">Submit</a></b-button>
      </div>
  </div>
</template>

<script>
  import axios from 'axios'
  import VueAxios from 'vue-axios'
  import Vue from 'vue'
  import VueRouter from 'vue-router'
  Vue.use(VueRouter)

  Vue.use(VueAxios, axios, VueRouter)
  export default {
      name: 'CreateView',
      components: {
      },
      data() {
          return {
              form: {
                  name: '',
                  description: '',
                  alcoholpercentage: ''
              }
          }
      },
      methods: {
          onSubmit(event) {
              event.preventDefault()
              console.warn(this.form)
              axios({
                  method: 'post',
                  url: 'https://localhost:7168/api/beers/Create',
                  data: {
                      "name": this.form.name,
                      "description": this.form.description,
                      "alcoholpercentage": this.form.alcoholpercentage
                  }
              })
          }
      }
  }
</script>

<style scoped>
  .rate{
      margin-left: 50px;
      margin-bottom: 25px;
  }

  .rate-comment{
      margin-top: 25px;
      margin-bottom: 25px;
  }

  .btn{
      margin-left: 10px;
  }

  .nav{
      color: white;
  }
</style>