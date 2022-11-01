import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-my-d-b-speaker', 'Unit | Model | i-i-s-my-d-b-speaker', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-my-d-b-book',
    'model:i-i-s-my-d-b-class-meeting',
    'model:i-i-s-my-d-b-presntation',
    'model:i-i-s-my-d-b-speaker',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
