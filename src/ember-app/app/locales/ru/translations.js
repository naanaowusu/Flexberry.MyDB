import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

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
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'My DB',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'My DB',
          title: 'My DB'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
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
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
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
