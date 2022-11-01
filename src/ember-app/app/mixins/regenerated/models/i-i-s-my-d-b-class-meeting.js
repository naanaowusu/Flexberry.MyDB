import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  meetingDate: DS.attr('date'),
  presntation: DS.hasMany('i-i-s-my-d-b-presntation', { inverse: 'classMeeting', async: false })
});

export let ValidationRules = {
  meetingDate: {
    descriptionKey: 'models.i-i-s-my-d-b-class-meeting.validations.meetingDate.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  presntation: {
    descriptionKey: 'models.i-i-s-my-d-b-class-meeting.validations.presntation.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ClassMeetingE', 'i-i-s-my-d-b-class-meeting', {
    meetingDate: attr('Meeting date', { index: 0 }),
    presntation: hasMany('i-i-s-my-d-b-presntation', 'Presntation', {
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
    })
  });

  modelClass.defineProjection('ClassMeetingL', 'i-i-s-my-d-b-class-meeting', {
    meetingDate: attr('Meeting date', { index: 0 })
  });
};
