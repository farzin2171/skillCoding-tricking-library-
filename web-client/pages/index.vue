<template>
  <v-layout
    column
    justify-center
    align-center
  >
    <v-flex
      xs12
      sm8
      md6
    >
      <div class="text-center">
        <logo />
        <vuetify-logo />
      </div>
      <v-card>
        <v-card-title class="headline">
         {{message}}
         <v-btn @click="reset" >Reset</v-btn>
        </v-card-title>
      
      </v-card>
    </v-flex>
  </v-layout>
</template>

<script>
import Axios from 'axios'
import Logo from '~/components/Logo.vue'
import VuetifyLogo from '~/components/VuetifyLogo.vue'
import {mapState,mapActions,mapMutations} from 'vuex';
export default {
  components: {
    Logo,
    VuetifyLogo
  },
  computed:mapState({
    message:state=>state.message
  }),
  methods:mapMutations([
    'reset'
  ])
}
</script>
