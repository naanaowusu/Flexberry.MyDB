import {
  defineNamespace,
  defineProjections,
  Model as BookMixin
} from '../mixins/regenerated/models/i-i-s-my-d-b-book';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(BookMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
