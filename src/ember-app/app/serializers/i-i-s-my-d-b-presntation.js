import { Serializer as PresntationSerializer } from
  '../mixins/regenerated/serializers/i-i-s-my-d-b-presntation';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(PresntationSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
