import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-my-d-b-book-l');
  this.route('i-i-s-my-d-b-book-e',
  { path: 'i-i-s-my-d-b-book-e/:id' });
  this.route('i-i-s-my-d-b-book-e.new',
  { path: 'i-i-s-my-d-b-book-e/new' });
  this.route('i-i-s-my-d-b-class-meeting-l');
  this.route('i-i-s-my-d-b-class-meeting-e',
  { path: 'i-i-s-my-d-b-class-meeting-e/:id' });
  this.route('i-i-s-my-d-b-class-meeting-e.new',
  { path: 'i-i-s-my-d-b-class-meeting-e/new' });
  this.route('i-i-s-my-d-b-speaker-l');
  this.route('i-i-s-my-d-b-speaker-e',
  { path: 'i-i-s-my-d-b-speaker-e/:id' });
  this.route('i-i-s-my-d-b-speaker-e.new',
  { path: 'i-i-s-my-d-b-speaker-e/new' });
});

export default Router;
