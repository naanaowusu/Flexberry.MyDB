import {
  defineNamespace,
  defineProjections,
  Model as ClassMeetingMixin
} from '../mixins/regenerated/models/i-i-s-my-d-b-class-meeting';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ClassMeetingMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
