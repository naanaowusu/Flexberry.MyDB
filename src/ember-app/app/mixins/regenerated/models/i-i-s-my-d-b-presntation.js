import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  bookReview: DS.attr('string'),
  bookScore: DS.attr('number'),
  presentationURL: DS.attr('string'),
  videoURL: DS.attr('string'),
  book: DS.belongsTo('i-i-s-my-d-b-book', { inverse: null, async: false }),
  speaker: DS.belongsTo('i-i-s-my-d-b-speaker', { inverse: null, async: false }),
  classMeeting: DS.belongsTo('i-i-s-my-d-b-class-meeting', { inverse: 'presntation', async: false })
});

export let ValidationRules = {
  bookReview: {
    descriptionKey: 'models.i-i-s-my-d-b-presntation.validations.bookReview.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  bookScore: {
    descriptionKey: 'models.i-i-s-my-d-b-presntation.validations.bookScore.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  presentationURL: {
    descriptionKey: 'models.i-i-s-my-d-b-presntation.validations.presentationURL.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  videoURL: {
    descriptionKey: 'models.i-i-s-my-d-b-presntation.validations.videoURL.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  book: {
    descriptionKey: 'models.i-i-s-my-d-b-presntation.validations.book.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  speaker: {
    descriptionKey: 'models.i-i-s-my-d-b-presntation.validations.speaker.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  classMeeting: {
    descriptionKey: 'models.i-i-s-my-d-b-presntation.validations.classMeeting.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('PresntationE', 'i-i-s-my-d-b-presntation', {
    bookScore: attr('Book score', { index: 0 }),
    presentationURL: attr('Presentation URL', { index: 1 }),
    videoURL: attr('Video URL', { index: 2 }),
    bookReview: attr('Book review', { index: 3 }),
    book: belongsTo('i-i-s-my-d-b-book', 'Book', {
      name: attr('Name', { index: 5, hidden: true })
    }, { index: 4, displayMemberPath: 'name' }),
    speaker: belongsTo('i-i-s-my-d-b-speaker', 'Speaker', {
      firstName: attr('First name', { index: 7, hidden: true })
    }, { index: 6, displayMemberPath: 'firstName' })
  });
};
