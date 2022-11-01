import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as SpeakerMixin
} from '../mixins/regenerated/models/i-i-s-my-d-b-speaker';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(SpeakerMixin, Validations, {
});

defineProjections(Model);

export default Model;
