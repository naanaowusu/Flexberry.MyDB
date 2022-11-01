import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-my-d-b-class-meeting', 'Unit | Serializer | i-i-s-my-d-b-class-meeting', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-my-d-b-class-meeting',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
