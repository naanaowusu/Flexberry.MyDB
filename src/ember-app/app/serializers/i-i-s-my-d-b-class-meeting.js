import { Serializer as ClassMeetingSerializer } from
  '../mixins/regenerated/serializers/i-i-s-my-d-b-class-meeting';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ClassMeetingSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
