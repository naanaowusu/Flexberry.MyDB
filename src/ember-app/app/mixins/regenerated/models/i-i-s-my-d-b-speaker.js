import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  firstName: DS.attr('string'),
  lastName: DS.attr('string')
});

export let ValidationRules = {
  firstName: {
    descriptionKey: 'models.i-i-s-my-d-b-speaker.validations.firstName.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  lastName: {
    descriptionKey: 'models.i-i-s-my-d-b-speaker.validations.lastName.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('SpeakerE', 'i-i-s-my-d-b-speaker', {
    firstName: attr('First name', { index: 0 }),
    lastName: attr('Last name', { index: 1 })
  });

  modelClass.defineProjection('SpeakerL', 'i-i-s-my-d-b-speaker', {
    firstName: attr('First name', { index: 0 }),
    lastName: attr('Last name', { index: 1 })
  });
};
