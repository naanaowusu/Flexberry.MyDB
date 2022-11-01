import {
  defineNamespace,
  defineProjections,
  Model as SpeakerMixin
} from '../mixins/regenerated/models/i-i-s-my-d-b-speaker';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(SpeakerMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
