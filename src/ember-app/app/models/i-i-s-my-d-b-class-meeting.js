import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as ClassMeetingMixin
} from '../mixins/regenerated/models/i-i-s-my-d-b-class-meeting';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ClassMeetingMixin, Validations, {
});

defineProjections(Model);

export default Model;
