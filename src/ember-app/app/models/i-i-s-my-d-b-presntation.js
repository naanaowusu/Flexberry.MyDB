import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as PresntationMixin
} from '../mixins/regenerated/models/i-i-s-my-d-b-presntation';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(PresntationMixin, Validations, {
});

defineProjections(Model);

export default Model;
