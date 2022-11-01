import { Serializer as BookSerializer } from
  '../mixins/regenerated/serializers/i-i-s-my-d-b-book';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(BookSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
