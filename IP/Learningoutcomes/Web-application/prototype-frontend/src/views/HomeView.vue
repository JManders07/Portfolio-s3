<template>
  <div class="home">
    <b-card v-for="beer in beerList" :key="beer.amount"
                            :title="beer.name"
                            tag="beer"
                            class="mb-2 allCards"
                            align="center">
                        <b-card-text>
                            {{beer.description}}
                        </b-card-text>
                        <b-button href="beer.url" variant="danger">Read more</b-button>
                    </b-card>
  </div>
</template>

<script>
import axios from 'axios'
    import VueAxios from 'vue-axios'
    import Vue from 'vue'

    Vue.use(VueAxios, axios)

export default {
  name: 'HomeView',
  components: {
    
  },
  data() {
    return {
      beerList: null,
    }
  },
  mounted(){
    axios
      .get('https://localhost:7168/api/beers/allbeers')
      .then(response=> {
        this.beerList = response.data
        console.warn(this.beerList)
      })
  }
}
</script>
