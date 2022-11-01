import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  author: DS.attr('string'),
  coverURL: DS.attr('string'),
  descriptionURL: DS.attr('string'),
  name: DS.attr('string'),
  pagesCount: DS.attr('number'),
  tags: DS.attr('string')
});

export let ValidationRules = {
  author: {
    descriptionKey: 'models.i-i-s-my-d-b-book.validations.author.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  coverURL: {
    descriptionKey: 'models.i-i-s-my-d-b-book.validations.coverURL.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  descriptionURL: {
    descriptionKey: 'models.i-i-s-my-d-b-book.validations.descriptionURL.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  name: {
    descriptionKey: 'models.i-i-s-my-d-b-book.validations.name.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  pagesCount: {
    descriptionKey: 'models.i-i-s-my-d-b-book.validations.pagesCount.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  tags: {
    descriptionKey: 'models.i-i-s-my-d-b-book.validations.tags.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('BookE', 'i-i-s-my-d-b-book', {
    name: attr('Name', { index: 0 }),
    author: attr('Author', { index: 1 }),
    pagesCount: attr('Pages count', { index: 2 }),
    coverURL: attr('Cover URL', { index: 3 }),
    descriptionURL: attr('Description URL', { index: 4 }),
    tags: attr('Tags', { index: 5 })
  });

  modelClass.defineProjection('BookL', 'i-i-s-my-d-b-book', {
    name: attr('Name', { index: 0 }),
    author: attr('Author', { index: 1 }),
    pagesCount: attr('Pages count', { index: 2 }),
    coverURL: attr('Cover URL', { index: 3 }),
    descriptionURL: attr('Description URL', { index: 4 }),
    tags: attr('Tags', { index: 5 })
  });
};
