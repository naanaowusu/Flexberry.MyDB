import {
  defineNamespace,
  defineProjections,
  Model as PresntationMixin
} from '../mixins/regenerated/models/i-i-s-my-d-b-presntation';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(PresntationMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
