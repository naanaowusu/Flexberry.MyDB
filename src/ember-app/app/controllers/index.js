import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.my-d-b.caption'),
          title: i18n.t('forms.application.sitemap.my-d-b.title'),
          children: [{
            link: 'i-i-s-my-d-b-class-meeting-l',
            caption: i18n.t('forms.application.sitemap.my-d-b.i-i-s-my-d-b-class-meeting-l.caption'),
            title: i18n.t('forms.application.sitemap.my-d-b.i-i-s-my-d-b-class-meeting-l.title'),
            icon: 'phone',
            children: null
          }, {
            link: 'i-i-s-my-d-b-speaker-l',
            caption: i18n.t('forms.application.sitemap.my-d-b.i-i-s-my-d-b-speaker-l.caption'),
            title: i18n.t('forms.application.sitemap.my-d-b.i-i-s-my-d-b-speaker-l.title'),
            icon: 'suitcase',
            children: null
          }, {
            link: 'i-i-s-my-d-b-book-l',
            caption: i18n.t('forms.application.sitemap.my-d-b.i-i-s-my-d-b-book-l.caption'),
            title: i18n.t('forms.application.sitemap.my-d-b.i-i-s-my-d-b-book-l.title'),
            icon: 'chart bar',
            children: null
          }]
        }
      ]
    };
  }),
})