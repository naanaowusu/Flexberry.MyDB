import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISMyDBBookLForm from './forms/i-i-s-my-d-b-book-l';
import IISMyDBClassMeetingLForm from './forms/i-i-s-my-d-b-class-meeting-l';
import IISMyDBSpeakerLForm from './forms/i-i-s-my-d-b-speaker-l';
import IISMyDBBookEForm from './forms/i-i-s-my-d-b-book-e';
import IISMyDBClassMeetingEForm from './forms/i-i-s-my-d-b-class-meeting-e';
import IISMyDBSpeakerEForm from './forms/i-i-s-my-d-b-speaker-e';
import IISMyDBBookModel from './models/i-i-s-my-d-b-book';
import IISMyDBClassMeetingModel from './models/i-i-s-my-d-b-class-meeting';
import IISMyDBPresntationModel from './models/i-i-s-my-d-b-presntation';
import IISMyDBSpeakerModel from './models/i-i-s-my-d-b-speaker';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-my-d-b-book': IISMyDBBookModel,
    'i-i-s-my-d-b-class-meeting': IISMyDBClassMeetingModel,
    'i-i-s-my-d-b-presntation': IISMyDBPresntationModel,
    'i-i-s-my-d-b-speaker': IISMyDBSpeakerModel
  },

  'application-name': 'My DB',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'My DB',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'My DB',
          title: 'My DB'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        'my-d-b': {
          caption: 'MyDB',
          title: 'MyDB',
          'i-i-s-my-d-b-class-meeting-l': {
            caption: 'Class meeting',
            title: ''
          },
          'i-i-s-my-d-b-speaker-l': {
            caption: 'Speaker',
            title: ''
          },
          'i-i-s-my-d-b-book-l': {
            caption: 'Book',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-my-d-b-book-l': IISMyDBBookLForm,
    'i-i-s-my-d-b-class-meeting-l': IISMyDBClassMeetingLForm,
    'i-i-s-my-d-b-speaker-l': IISMyDBSpeakerLForm,
    'i-i-s-my-d-b-book-e': IISMyDBBookEForm,
    'i-i-s-my-d-b-class-meeting-e': IISMyDBClassMeetingEForm,
    'i-i-s-my-d-b-speaker-e': IISMyDBSpeakerEForm
  },

});

export default translations;
